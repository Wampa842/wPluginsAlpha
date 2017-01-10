------------------------------------------------
|            ____  _             _             |
|  __      _|  _ \| |_   _  __ _(_)_ __  ___   |
|  \ \ /\ / / |_) | | | | |/ _` | | '_ \/ __|  |
|   \ V  V /|  __/| | |_| | (_| | | | | \__ \  |
|    \_/\_/ |_|   |_|\__,_|\__, |_|_| |_|___/  |
|                          |___/               |
------------------------------------------------

A plugin bundle for PMX Editor
Developed by Wampa842

Downloads: https://github.com/Wampa842/wPlugins/releases

Source Code: https://github.com/Wampa842/wPlugins
License: MIT (see LICENSE.txt)

------------------------------------------------
Contact info:
	e-mail:			wampa842@gmail.com
	deviantART:		wampa842.deviantart.com
	GitHub:			github.com/Wampa842


----------------------------
------    FEATURES    ------
----------------------------

Currently functional plugins:
	> wMorphScale:
		Scale the offsets of a vertex, UV or bone morph.
		Shortcuts to negative (-x) or inverse (1/x) transformations.
	> wAverageVertexPosition:
		Move selected vertices to the same location without welding them.
		Options to set the position, normal, or both; and to only merge vertices within a set range.
	> wApplyMorph:
		Apply a vertex morph, or its negative, to the model in the editor.
	> wPluginsSettings:
		Settings utility for the plugins in the bundle.
		Options to store settings in a file, and to auto-start plugins with PMX.
	
Planned plugins:
	> wMirrorSelected:
		Mirror only selected objects instead of the entire model. Optionally, duplicate them.
	> wBackup:
		Automatic backup utility with configurable interval, backup location, naming, and notifications.
	> wMeasuringTape:
		Measure the distance between two selected objects.
		Measure the angle between an axis and two selected objects, or a bone's look-at bone.
		Built-in calculator with PMX-specific shortcuts.
	> wTranslate:
		A reimplementation of PMX's own utility with extras, in English.
		Crowdsourced translation database, pulled from the Internet.
	> wSafeWeld:
		A tool to weld/merge/join vertices with respect to UV and weight boundaries, and non-unified vertex normals.
		Avoid unwanted smoothing, weight merging and UV warping.
	> wHelloWorld:
		A "hello world" type program, to show the basics of plugin creation. Mainly meant for programmers.
		
----------------------------
----    INSTALLATION    ----
----------------------------

1) Download the latest release from the link at the top of this file.
2) Right-click on the ZIP file, click on Properties, then click on Unblock
3) Extract the "wPlugins" folder into "path\to\PMX Editor\_plugin\User".
4) You're done. Start PMX Editor.
5) wPluginsSettings will start up automatically. Configure the plugins to your liking.
	

----------------------------
----	REQUIREMENTS    ----
----------------------------

PMX Editor. The plugins will not work with the legacy PMD Editor.

The plugins require .NET Framework 4.0 or later.

	On Windows 8, 8.1 and 10: use Windows Update to download the newest version.

	On Windows 7 or earlier:
.NET Framework 4.0 (web installer): https://www.microsoft.com/en-us/download/details.aspx?id=17851
.NET Framework 4.5 (web installer): https://www.microsoft.com/en-us/download/details.aspx?id=30653

.NET Framework 4.0 (offline): https://www.microsoft.com/en-us/download/details.aspx?id=17718
.NET Framework 4.5 (offline): https://www.microsoft.com/en-us/download/details.aspx?id=42642

---------------------------------
--    TROUBLESHOOTING & FAQ    --
---------------------------------

Issue:
	I'm getting an error message saying something about a missing assembly.
Fix:
	Make sure you download .NET Framework 4.0 or newer. See REQUIREMENTS above.

Issue:
	I'm getting an error message in Japanese.
	OR: I'm getting an error saying the plugin couldn't be initialized.
Fix:
	For security reasons, machine code files (.exe and .dll) downloaded from the Internet are blocked by Windows.
	See INSTALLATION step 2 for the procedure.

Issue:
	I'm getting an "Unhandled Exception" error and PMX Editor crashes.
Fix:
	Here's your chance to become part of the development!
	The best thing you can do is contact me (see above for contact info).
	First of all, DO NOT close the error message. Click on "Details" and send everything you find there to me in a message.
	Tell me what you did when the error appeared, and if it's a recurring error. I'll do everything I can to resolve the
	problem.

Q::
	I want to use wPlugins with the old PMD Editor. Can I?
A:
	The short answer is no. Update to PMX Editor.
	The long answer is, maybe later. The plugin API uses different methods for PMX and PMD operations. I'd have to
	rewrite much of the code to ensure functionality with PMD Editor. If you're up to it, you can fork my code to do
	it yourself.

Q:
	Your plugin broke my model! How do I fix it?
A:
	This shouldn't happen, but if it does, there's not much I can do to fix the model.
	Contact me (see above) and tell me what you did, what should've happened, and what actually went wrong.
	
Q:
	<problem not related to wPlugins>
A:
	If it's not my problem, there's not much I can do to resolve it that isn't available on Google. That said, if you're nice enough, I'll help you anyways.

Q:
	I'd like a plugin that does <this>!
A:
	I'm always open to suggestions, but there's a chance your idea is not possible to implement. Even then, this isn't a request offer - I may choose not to implement it.

	FOR PROGRAMMERS:
	The code is licensed under the MIT License, which is very permissive. Feel free to fork my code and mess around with it. You can compile and release it yourself (under MIT's terms), or make a pull request to see your code in the official wPlugins repo.

Issue:
	You're such an idiot, everybody knows that <this> should be done <this way>!
Fix:
	Apply a shovel to your face in generous quantities. If you can't be nice to others, you shouldn't be around them.
