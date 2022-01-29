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
    public class ClingingShadowsInitiate : Template
    {
        public static readonly Guid ID = Guid.Parse("151b1a4c-6844-4294-b8dc-dc96eb18507f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Clinging Shadows Initiate",
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
            yield return new TextBlock { Id = Guid.Parse("41cd2f21-d61f-46f8-874e-b7de9ae5f3fd"), Type = TextBlockType.Text, Text = $"You learn a mystical stance that transforms your ki into sticky smoke that shrouds your limbs, clinging to everything you touch. You gain the {ToMarkdownLink<Models.Entities.Spell>("clinging shadows stance", Spells.Instances.ClingingShadowsStance.ID)} ki spell. Increase the number of Focus Points in your focus pool by 1. While entering the stance uses a ki spell, the shadow grasp attacks it grants are not, so you can use them as often as you like while in the stance." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyKiSpells(Guid.Parse("63706276-19ae-4e7a-ad7d-6f08902c35a9"));
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("8aef9c55-bdb5-4f9c-bb3d-bdbf2fd3ae68"), Traits.Instances.Monk.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d2c28f5d-cde1-4484-bc16-8271ec163ac5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
