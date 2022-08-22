Modified version of Xp3Pack from arcusmaximus's KirikiriTools made to work with Linux Mono.

`mono Xp3Pack.exe <PATH_TO_TARGET_FOLDER>`

# KirikiriTools
Tools for the Kirikiri visual novel engine. [Download page](https://github.com/arcusmaximus/KirikiriTools/releases)

If you're looking to translate a Kirikiri game, take a look at [VNTextPatch](https://github.com/arcusmaximus/VNTranslationTools).

## Xp3Pack
Creates unencrypted .xp3 archives for use with the KirikiriUnencryptedArchive DLL. Unlike other packing tools, it sets all hashes in the file table to zero; this serves as a marker for the DLL to bypass the game's decryption for those files.

Typical usage is to place Xp3Pack.exe in the game folder, create a "patch" subfolder containing the files you want to include, and run "Xp3Pack patch" from the command line. This will create a patch.xp3 in the game folder. If the game already has its own patch.xp3, name your folder "patch2" and run "Xp3Pack patch2" instead. If the game already has a patch2.xp3, name your folder "patch3", and so on.
