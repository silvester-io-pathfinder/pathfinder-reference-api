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
    public class ExpandAura : Template
    {
        public static readonly Guid ID = Guid.Parse("9a0334d4-313f-42c0-813b-06dea7931840");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Expand Aura",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8e8a8fa0-4e48-4308-8d3c-221a8bc75aad"), Type = TextBlockType.Text, Text = $"You focus your divine power to extend your influence. Select one aura you have from a champion feat or feature, such as {ToMarkdownLink<Models.Entities.Feat>("Aura of Courage", Feats.Instances.AuraOfCourage.ID)} or {ToMarkdownLink<Models.Entities.Feat>("Aura of Life", Feats.Instances.AuraOfLife.ID)}. The radius of the aura is doubled until the start of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            //TODO: Add prerequisites.
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ec59bead-f967-4357-b485-e84ed207205e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
