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
    public class ModificationPacificationTools : Template
    {
        public static readonly Guid ID = Guid.Parse("603c0fa2-c3d5-4411-b5a6-3bd31fd39326");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Pacification Tools",
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
            yield return new TextBlock { Id = Guid.Parse("c9d92aa6-50aa-48e8-9d33-1c7af2382eee"), Type = TextBlockType.Enumeration, Text = $"*Melee Only**" };
            yield return new TextBlock { Id = Guid.Parse("acf1bafd-1771-4f90-981a-14ca17d284f0"), Type = TextBlockType.Text, Text = $"Softer materials make your weapon suited to knock out instead of kill, and special protrusions let you catch weapons and disarm your foes. Your innovation gains the {ToMarkdownLink<Models.Entities.Trait>("disarm", Traits.Instances.Disarm.ID)} and {ToMarkdownLink<Models.Entities.Trait>("nonlethal", Traits.Instances.Nonlethal.ID)} traits. You can choose whether to apply the {ToMarkdownLink<Models.Entities.Trait>("nonlethal", Traits.Instances.Nonlethal.ID)} trait on each attack with your innovation." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bacda581-b8b9-4846-a244-ffb4f4059b04"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
