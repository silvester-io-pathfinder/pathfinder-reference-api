using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SnareSetter : Template
    {
        public static readonly Guid ID = Guid.Parse("52a8e1a2-870e-4812-b479-d62a773308de");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Snare Setter",
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
            yield return new TextBlock { Id = Guid.Parse("0138ab6a-0500-4f85-a234-51043a4d40c0"), Type = TextBlockType.Text, Text = $"You are adept at the time-honored kobold art of trap making. You gain the trained proficiency in Crafting. If you were already trained in Crafting, you instead become trained in a skill of your choice. You gain access to all uncommon kobold snares. You gain the {ToMarkdownLink<Models.Entities.Feat>("Snare Crafting", Feats.Instances.SnareCrafting.ID)} feat, though when choosing your formulas for that feat, you can also choose from uncommon kobold snares, as well as common snares." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a1da378c-0c5d-4e15-b460-f318da562bd3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
