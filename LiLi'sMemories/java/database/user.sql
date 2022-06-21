-- ********************************************************************************
-- This script creates the database users and grants them the necessary permissions
-- ********************************************************************************

CREATE USER lilis_memories_owner
WITH PASSWORD 'lilismemories';

GRANT ALL
ON ALL TABLES IN SCHEMA public
TO lilis_memories_owner;

GRANT ALL
ON ALL SEQUENCES IN SCHEMA public
TO lilis_memories_owner;

CREATE USER lilis_memories_appuser
WITH PASSWORD 'lilismemories';

GRANT SELECT, INSERT, UPDATE, DELETE
ON ALL TABLES IN SCHEMA public
TO lilis_memories_appuser;

GRANT USAGE, SELECT
ON ALL SEQUENCES IN SCHEMA public
TO lilis_memories_appuser;
