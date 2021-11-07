using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WizardElementalistFire : Template
    {
        public static readonly Guid ID = Guid.Parse("8ba1d989-c194-4e95-b356-d125dbff1098");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wizard Elementalist - Fire",
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
            yield return new TextBlock { Id = Guid.Parse("89bc56bb-47d8-4b8a-b044-b801f3007766"), Type = TextBlockType.Text, Text = "Instead of specializing in a school of magic, you specialize in one of the four elements: fire. Any benefits your arcane school would grant you that are associated with a selected spell school, you instead apply to your selected element." };
            yield return new TextBlock { Id = Guid.Parse("43676958-c198-4381-b1e0-ceb0feb2ac40"), Type = TextBlockType.Text, Text = "In place of your arcane school spell, you learn the initial fire elemental focus spell ((spell: wildfire)). If you later select the (feat: Advanced School Spell) wizard feat, instead of gaining the listed school spell, you gain the advanced fire elemental focus spell ((spell: combustion))." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("76495f98-f281-4686-b0c7-b1ec14734a79"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
