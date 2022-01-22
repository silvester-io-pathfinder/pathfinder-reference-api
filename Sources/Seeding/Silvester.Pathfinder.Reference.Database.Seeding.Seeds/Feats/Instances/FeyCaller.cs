using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FeyCaller : Template
    {
        public static readonly Guid ID = Guid.Parse("e9a65e9a-c01a-4a0e-a73f-939c726a2c6e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fey Caller",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c1844c96-25df-4b12-97c9-da1dd6e6a2d9"), Type = TextBlockType.Text, Text = $"You have learned some of the tricks the fey use to bend primal magic toward illusions and trickery. Add {ToMarkdownLink<Models.Entities.Spell>("illusory disguise", Spells.Instances.IllusoryDisguise.ID)}, {ToMarkdownLink<Models.Entities.Spell>("illusory object", Spells.Instances.IllusoryObject.ID)}, {ToMarkdownLink<Models.Entities.Spell>("illusory scene", Spells.Instances.IllusoryScene.ID)}, and {ToMarkdownLink<Models.Entities.Spell>("veil", Spells.Instances.Veil.ID)} to your spell list as primal spells." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("084e7072-2404-4a08-8d0f-8bb7013931bc"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
