using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WizardElementalistAir : Template
    {
        public static readonly Guid ID = Guid.Parse("75d6bd73-625f-40ce-868b-841780422f9c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wizard Elementalist - Air",
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
            yield return new TextBlock { Id = Guid.Parse("59b326ee-b431-4f7c-84a7-b60275f4c814"), Type = TextBlockType.Text, Text = "Instead of specializing in a school of magic, you specialize in one of the four elements: air. Any benefits your arcane school would grant you that are associated with a selected spell school, you instead apply to your selected element." };
            yield return new TextBlock { Id = Guid.Parse("8c12bd30-ab75-494e-9137-31e89651be11"), Type = TextBlockType.Text, Text = "In place of your arcane school spell, you learn the initial air elemental focus spell ((spell: updraft)). If you later select the (feat: Advanced School Spell) wizard feat, instead of gaining the listed school spell, you gain the advanced air elemental focus spell ((spell: powerful inhalation))." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("64bb326f-0921-44f6-804a-903bce9bbc4b"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
