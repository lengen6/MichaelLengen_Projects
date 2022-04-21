// App Congig
const express = require("express"),
      app = express(),
      bodyParser = require("body-parser"),
      axios = require("axios"),
      mongoose = require('mongoose'),
      methodOverride = require("method-override");
      expressSanitizer = require("express-sanitizer")

app.use(bodyParser.urlencoded({extended: true}));
app.use(expressSanitizer());
app.use(express.static("public"));
app.set("view engine", "ejs");
app.use(methodOverride("_method"))

// Connect to Database
mongoose.connect('mongodb://localhost:27017/blog_app', {
  useNewUrlParser: true,
  useUnifiedTopology: true,
  useFindAndModify: false
})
.then(() => console.log('Connected to DB!'))
.catch(error => console.log(error.message));

// Create database model
const blogSchema = new mongoose.Schema({
  title: String,
  image: String,
  body: String,
  created: {type: Date, default: Date.now}
});

const Blog = mongoose.model("Blog", blogSchema);

// Routes

// Home
app.get("/", (req, res) => {
  res.redirect("/blogs")
})

// Index
app.get("/blogs", (req, res) => {
  Blog.find({})
  .then((blogs) => res.render("index", {blogs: blogs}))
  .catch(err => console.log(err))
});

// New
app.get("/blogs/new", (req, res) =>{
  res.render("new")
})

// Create
app.post("/blogs", (req, res) => {
  req.body.blog.body = req.sanitize(req.body.blog.body)
  Blog.create(req.body.blog)
  .then(newBlog => res.redirect("/blogs"))
  .catch(err => res.render("/new"))
})
 
// Show
app.get("/blogs/:id", (req, res) => {
  Blog.findById(req.params.id)
  .then(foundBlog => res.render("show", {blog: foundBlog}))
  .catch(err => res.redirect("/blogs"))
})

// Edit
app.get("/blogs/:id/edit", (req, res) => {
  // Find the same way as the show route
  Blog.findById(req.params.id)
  .then(foundBlog => res.render("edit", {blog: foundBlog}))
  .catch(err => res.redirect("/blogs"))
})

// Update
app.put("/blogs/:id", (req, res) => {
  req.body.blog.body = req.sanitize(req.body.blog.body)
  Blog.findByIdAndUpdate(req.params.id, req.body.blog)
  .then(updatedBlog => res.redirect("/blogs/" + req.params.id))
  .catch(err => res.redirect("/blogs"));
})

// Delete
app.delete("/blogs/:id", (req, res)=> {
  Blog.findByIdAndRemove(req.params.id)
  .then(()=> res.redirect("/blogs"))
  .catch(err => res.redirect("/blogs"))
})

app.listen(3000, () =>{
  console.log("All Systems Go")
});