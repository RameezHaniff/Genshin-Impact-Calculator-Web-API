# About this project
Genshin Damage Calculator is a Web API created in the ASP.NET framework for Genshin Impact.As this is a tool to cater to every character in the game, it is difficult to develop all characters at once. Currently the only data supported are character, ability and scaling information with the only completed characters being Amber, Barbara, Bennett and Beidou. The database is written in PostgreSQL. The skeleton data for all other characters exist however, and will be completed with each addition to the API. 

This API is intended to be used with the Genshin Impact Calculator which can be found [here](https://github.com/RameezHaniff/Genshin-Impact-Calculator.git).

# What can the API be used for (currently)
* Basic character information
* Ability Data
* Ability Scalings

# What can be expected in the future?
* Completion of character data
* Artifact and weapon data
* Constellation data
* Team storage functionality

# How to install the SQL database
* Since the database is written in PostgreSQL the database can be added by using the restore function in [pgAdmin 4](https://www.pgadmin.org/docs/pgadmin4/development/restore_dialog.html) or by using [psql SQL shell](https://www.postgresql.org/docs/current/backup-dump.html#BACKUP-DUMP-RESTORE) (both of which can be downloaded [here](https://www.postgresql.org/download/)) on the Sql dump within the Sql folder.
