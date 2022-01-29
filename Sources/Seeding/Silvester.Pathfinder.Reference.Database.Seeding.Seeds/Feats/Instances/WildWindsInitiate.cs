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
    public class WildWindsInitiate : Template
    {
        public static readonly Guid ID = Guid.Parse("4e9c5e2d-ecb7-4d73-b235-6ce99e24fdb4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wild Winds Initiate",
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
            yield return new TextBlock { Id = Guid.Parse("a208dfb3-5378-4f9c-b8f2-20d44a69b869"), Type = TextBlockType.Text, Text = $"You learn a mystical stance that lets you attack from a distance. You gain the {ToMarkdownLink<Models.Entities.Spell>("wild winds stance", Spells.Instances.WildWindsStance.ID)} ki spell. Increase the number of Focus Points in your focus pool by 1. While entering the stance is a ki spell, the wind crash {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} the stance grants are not, so you can use them as often as you like while in the stance." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyKiSpells(Guid.Parse("e82b61c5-970c-44a2-b49d-f54303ae7f16"));
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("b842d889-2adb-43ab-92fc-56eec4cb0e59"), Traits.Instances.Monk.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f0d44bdc-70b3-4ca9-a5a6-5d439acd06e3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
