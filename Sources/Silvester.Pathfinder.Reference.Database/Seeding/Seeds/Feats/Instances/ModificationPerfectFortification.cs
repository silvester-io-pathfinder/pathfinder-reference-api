using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationPerfectFortification : Template
    {
        public static readonly Guid ID = Guid.Parse("a3856f7d-0f33-4fd7-9393-c0ce1ad26d72");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Perfect Fortification",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b83c1a26-9353-476e-b070-a621549e13c5"), Type = TextBlockType.Enumeration, Text = "*Power Suit Only**" };
            yield return new TextBlock { Id = Guid.Parse("40a8e845-fecb-4ff9-ba5b-9a020bd463e3"), Type = TextBlockType.Text, Text = "You’ve outfitted your armor with such heavy fortifications that deadly attacks often lose their edge. Each time you’re critically hit while wearing the armor, attempt a DC 13 flat check. On a success, it becomes a normal hit. This isn’t cumulative with fortification runes or other abilities that reduce critical hits with a flat check. Additionally, you gain resistance 2 + half your level against precision damage." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cd0edd81-89ba-47d3-8515-38997f7b1947"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
