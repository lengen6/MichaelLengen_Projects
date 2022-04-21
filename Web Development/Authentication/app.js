const 
    express = require("express"),
    app = express(),
    port = process.env.Port || 3000,
    mongoose = require("mongoose"),
    passport = require("passport"),
    bodyParser = require("body-parser"),
    LocalStrategy = require("passport-local"),
    User = require("./models/user")
    passportLocalMongoose = require("passport-local-mongoose")
    flash = require("req-flash")

mongoose.connect('mongodb://localhost:27017/auth_demo', {
  useNewUrlParser: true,
  useUnifiedTopology: true
})
.then(() => console.log('Connected to DB!'))
.catch(error => console.log(error.message));


app.use(require("express-session")({
    secret: "Fuck Spiders",
    resave: false,
    saveUninitialized: false
}));
app.use(flash());

app.use(bodyParser.urlencoded({extended:true}));
app.set("view engine", "ejs");
app.use(passport.initialize());
app.use(passport.session());
passport.serializeUser(User.serializeUser());
passport.deserializeUser(User.deserializeUser());
passport.use(new LocalStrategy(User.authenticate()));

// ================
// Routes
// ================

app.get("/register", (req, res) =>{
    res.render("register", {extantUser: req.flash("extantUser")})
})

app.post("/register", (req, res) =>{
    req.body.username
    req.body.password
    User.findOne({username: req.body.username})
    .then(enteredUser => {
        if(enteredUser) {
            console.log("Already Exists")
            req.flash("extantUser", "A user with that name already exists")
            res.redirect("/register");
        } else {
            User.register(new User({username: req.body.username}), req.body.password)
            .then(() => {
                passport.authenticate("local")
                res.redirect("/secret")
            })
        }
    })
    .catch(err => {
        console.log(err)
    })
    });

app.get("/login", (req, res) =>{
    res.render("login")
})

app.get("/", (req, res) =>{
    res.render("home")
})

app.post("/login", passport.authenticate("local", {
    successRedirect: "/secret",
    failureRedirect: "login"
}), (req, res) =>{

});

app.get("/secret", isLoggedIn, (req, res) => {
    res.render("secret")
})    

app.get("/logout", (req, res) =>{
    req.logout();
    res.redirect("/")
})

function isLoggedIn(req, res, next){
    if(req.isAuthenticated()){
        return next()
    }
    res.redirect("/login")
}

app.listen(port, () => console.log("All Systems Go"))