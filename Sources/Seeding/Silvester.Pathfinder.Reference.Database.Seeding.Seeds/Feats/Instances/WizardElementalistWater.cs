using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WizardElementalistWater : Template
    {
        public static readonly Guid ID = Guid.Parse("2b00049f-1ce6-4702-bb02-d489a6f72dd8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wizard Elementalist - Water",
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
            yield return new TextBlock { Id = Guid.Parse("1e82df84-302e-4d79-9216-c4a611287966"), Type = TextBlockType.Text, Text = $"Instead of specializing in a school of magic, you specialize in one of the four elements: water. Any benefits your arcane school would grant you that are associated with a selected spell school, you instead apply to your selected element." };
            yield return new TextBlock { Id = Guid.Parse("6dc56508-39d8-4aed-a122-9f2d04caca18"), Type = TextBlockType.Text, Text = $"In place of your arcane school spell, you learn the initial water elemental focus spell ({ToMarkdownLink<Models.Entities.Spell>("rising surf", Spells.Instances.RisingSurf.ID)}). If you later select the {ToMarkdownLink<Models.Entities.Feat>("Advanced School Spell", Feats.Instances.AdvancedSchoolSpell.ID)} wizard feat, instead of gaining the listed school spell, you gain the advanced water elemental focus spell ({ToMarkdownLink<Models.Entities.Spell>("pulverizing cascade", Spells.Instances.PulverizingCascade.ID)})." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3185b60d-b1d0-45d4-b3d7-884a6da93162"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
