using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WizardElementalistFire : Template
    {
        public static readonly Guid ID = Guid.Parse("853062ad-a96d-4ae7-b924-7f5222c99486");

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
            yield return new TextBlock { Id = Guid.Parse("2138ea85-f123-440a-80db-0eaaa3fa0935"), Type = TextBlockType.Text, Text = $"Instead of specializing in a school of magic, you specialize in one of the four elements: fire. Any benefits your arcane school would grant you that are associated with a selected spell school, you instead apply to your selected element." };
            yield return new TextBlock { Id = Guid.Parse("8081b0c4-15b5-4612-a861-e3e1658660ac"), Type = TextBlockType.Text, Text = $"In place of your arcane school spell, you learn the initial fire elemental focus spell ({ToMarkdownLink<Models.Entities.Spell>("wildfire", Spells.Instances.Wildfire.ID)}). If you later select the {ToMarkdownLink<Models.Entities.Feat>("Advanced School Spell", Feats.Instances.AdvancedSchoolSpell.ID)} wizard feat, instead of gaining the listed school spell, you gain the advanced fire elemental focus spell ({ToMarkdownLink<Models.Entities.Spell>("combustion", Spells.Instances.Combustion.ID)})." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cf18d9a1-fd57-402e-971b-ed4e319f8f8e"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
