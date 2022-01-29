using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WizardElementalistAir : Template
    {
        public static readonly Guid ID = Guid.Parse("5d423c85-0435-4955-ae42-0684bdbd2da8");

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
            yield return new TextBlock { Id = Guid.Parse("2f93a667-8fe5-4b8f-9541-f0ea7df26189"), Type = TextBlockType.Text, Text = $"Instead of specializing in a school of magic, you specialize in one of the four elements: air. Any benefits your arcane school would grant you that are associated with a selected spell school, you instead apply to your selected element." };
            yield return new TextBlock { Id = Guid.Parse("212964a2-ef0c-42d8-9a25-f3a3d84ea157"), Type = TextBlockType.Text, Text = $"In place of your arcane school spell, you learn the initial air elemental focus spell ({ToMarkdownLink<Models.Entities.Spell>("updraft", Spells.Instances.Updraft.ID)}). If you later select the {ToMarkdownLink<Models.Entities.Feat>("Advanced School Spell", Feats.Instances.AdvancedSchoolSpell.ID)} wizard feat, instead of gaining the listed school spell, you gain the advanced air elemental focus spell ({ToMarkdownLink<Models.Entities.Spell>("powerful inhalation", Spells.Instances.PowerfulInhalation.ID)})." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3b736421-f713-4ef6-8e78-49cc17b7ddef"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
