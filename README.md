js.Highlight
=============

A common location for Highlight.js and related script libraries for Orchard Project.

This module defines a script manifest for Highlight Library with name "Highlight".<br>
You can include Highlight script inside your Razor views using:<br>
Script.Require("Highlight")<br>

Highlight module will automatically insert your Highlight.js script in every page.<br>
You can disable this bevavior and include highlight on demand (using Script.Require("Highlight") inside your theme/view) by unchecking Auto Enable at highlight module settings.<br>

You can also select the full version of Highlight to automatically load on every page.<br>