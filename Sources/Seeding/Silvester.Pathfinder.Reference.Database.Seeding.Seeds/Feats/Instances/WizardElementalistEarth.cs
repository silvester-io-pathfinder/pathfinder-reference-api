using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WizardElementalistEarth : Template
    {
        public static readonly Guid ID = Guid.Parse("cef5a705-9cf3-4c60-9cba-3f6929118ba9");

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
            yield return new TextBlock { Id = Guid.Parse("a2ee40f5-9317-49cb-9724-dbe1545ddea3"), Type = TextBlockType.Text, Text = $"Instead of specializing in a school of magic, you specialize in one of the four elements: earth. Any benefits your arcane school would grant you that are associated with a selected spell school, you instead apply to your selected element." };
            yield return new TextBlock { Id = Guid.Parse("9b7a7db5-5dd5-45be-a11e-bcb6848f9a79"), Type = TextBlockType.Text, Text = $"In place of your arcane school spell, you learn the initial earth elemental focus spell ({ToMarkdownLink<Models.Entities.Spell>("crushing ground", Spells.Instances.CrushingGround.ID)}). If you later select the {ToMarkdownLink<Models.Entities.Feat>("Advanced School Spell", Feats.Instances.AdvancedSchoolSpell.ID)} wizard feat, instead of gaining the listed school spell, you gain the advanced earth elemental focus spell ({ToMarkdownLink<Models.Entities.Spell>("stone lance", Spells.Instances.StoneLance.ID)})." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e4c74eeb-8bb1-409a-8cc0-ada32f6a2cf6"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
