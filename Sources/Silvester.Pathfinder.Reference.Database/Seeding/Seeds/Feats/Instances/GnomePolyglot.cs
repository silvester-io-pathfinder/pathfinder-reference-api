using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GnomePolyglot : Template
    {
        public static readonly Guid ID = Guid.Parse("55d24113-22b3-4130-842e-32774905f199");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Gnome Polyglot",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7490297b-8f03-448f-8379-5e1a5ec73996"), Type = TextBlockType.Text, Text = "Your extensive travels, curiosity, and love of learning help you to learn languages quickly. You learn three new languages, chosen from common languages and uncommon languages you have access to. These languages take the same form (signed or spoken) as your other languages. When you select the (feat: Multilingual) feat, you learn three new languages instead of two." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0f31c7d4-da79-4f40-be49-3d68a168eb62"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
