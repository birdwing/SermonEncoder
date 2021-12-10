# SermonEncoder

Our church needed a simple way to encode our recorded sermons into both video and audio.
This program does that, as well as uploads it to our AWS instance, then can shutdown the computer when done.

You can give the sermon a name, list a speaker and a main scripture, this is output into an xml file which is also uploaded to AWS so the sermon meta data can be added to the database.

Program is not perfect, currently the encoding format is hard coded I hope to change that in the future.

The AWS lambda function used to import the uploaded files into the sermon database as well as the JavaScript api for displaying it on the website can be found here: https://github.com/birdwing/GWC_AWS_Sermon_Archive
That repo also contains files used to migrate our old sermons into the new database as well as test and example files.
