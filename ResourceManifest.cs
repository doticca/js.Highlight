using Orchard.UI.Resources;

namespace js.Highlight {
    public class ResourceManifest : IResourceManifestProvider {
        public void BuildManifests(ResourceManifestBuilder builder) {
            var manifest = builder.Add();

            // defaults at common highlight
            manifest.DefineScript("Highlight")
                .SetUrl("highlight.default.pack.js")                
                .SetVersion("8.2");

            manifest.DefineScript("Highlight_Full")
                .SetUrl("highlight.full.pack.js")
                .SetVersion("8.2");

            manifest.DefineStyle("Highlight_default")
                .SetVersion("8.2")
                .SetUrl("default.css", "default.css");
            manifest.DefineStyle("Highlight_xcode")
                .SetVersion("8.2")
                .SetUrl("xcode.css", "xcode.css");
        }
    }
}
