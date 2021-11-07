using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WizardElementalistEarth : Template
    {
        public static readonly Guid ID = Guid.Parse("08c5d778-23ed-46e5-8eb7-a0ce31fb64c9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wizard Elementalist - Earth",
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
            yield return new TextBlock { Id = Guid.Parse("74e915f2-4d90-47cb-a6c2-eab452262508"), Type = TextBlockType.Text, Text = "Instead of specializing in a school of magic, you specialize in one of the four elements: earth. Any benefits your arcane school would grant you that are associated with a selected spell school, you instead apply to your selected element." };
            yield return new TextBlock { Id = Guid.Parse("fb191a3a-0b21-496f-846b-0ff81437bc99"), Type = TextBlockType.Text, Text = "In place of your arcane school spell, you learn the initial earth elemental focus spell ((spell: crushing ground)). If you later select the (feat: Advanced School Spell) wizard feat, instead of gaining the listed school spell, you gain the advanced earth elemental focus spell ((spell: stone lance))." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("655bf1ff-5cfa-4f61-ac97-6081f3c0b916"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
