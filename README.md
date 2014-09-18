sc-update-tool-win
==================

Tool to assist in properly tagging files for use with the soundcloud updater.  Written in visual studio 2012.

Usage:

1. Create shortcut adding a command-line argument called upload-dir like this:
upload-dir=C:\sc-uploader\uploads

2. Run https://github.com/alandrees/soundcloud-auto-updater in the background (maybe in a scheduled task, maybe in a cron job) on the directory passed as an argument

3. ???

4. Upload to soundcloud!


Notes: 
- The downloadable and private flags are not yet functioning, either in the frontend (disabled) or backend (un-implemented).

- The icon must go in the same directory as the executable (for now).

- You don't need to specify a directory on the commandline, as the program defaults to ./uploads




