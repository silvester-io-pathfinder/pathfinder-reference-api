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
    public class FlensingSlice : Template
    {
        public static readonly Guid ID = Guid.Parse("3235c597-4254-40f1-a2ce-efccf48499e0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Flensing Slice",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("46881bbf-1fd5-4e38-9f60-a90ad206755d"), Type = TextBlockType.Text, Text = $"When you hit with both attacks with {ToMarkdownLink<Models.Entities.Feat>("Double Slice", Feats.Instances.DoubleSlice.ID)}, you flense the target, making it bleed and creating a weak spot. The target takes 1d8 persistent bleed damage per weapon damage die of whichever of the weapons you used that has the most weapon damage dice (maximum 4d8 for a {ToMarkdownLink<Models.Items.Instances.FundamentalWeaponRune>("major striking", Items.FundamentalWeaponRunes.Instances.Striking.ID)} weapon). The target becomes flat-footed, and its resistances to any physical damage types are reduced by 5; these two effects last until the beginning of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1d46d4b8-4633-4906-a72d-81ee38d53994"), Feats.Instances.DualWeaponWarriorDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("4170aa3d-3525-413a-9d0e-9569c4d7d904"), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("49a5ae3e-ef1e-486f-8585-98fc235383b9"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
