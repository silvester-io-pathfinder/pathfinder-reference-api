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
    public class AnkleBite : Template
    {
        public static readonly Guid ID = Guid.Parse("3a37e68b-9cee-4319-824f-6438255c397b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ankle Bite",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A foe gives you the grabbed or restrained condition using a part of its body.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ad4b29db-da66-4304-8e71-9d9059ad3e06"), Type = TextBlockType.Text, Text = $"Whenever someone grabs onto you, you instinctively bite down hard. Sometimes that makes them let go, and sometimes it just makes them angrier, but either way, it's both satisfying and tasty. Make a jaws {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against the triggering foe. On a critical hit, you are no longer grabbed. This {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} doesn't count toward your multiple attack penalty, and your multiple attack penalty doesn't apply to this {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("f29ae0ef-7097-43dd-ac79-785983068864"), or => 
            {
                or.HaveSpecificFeat(Guid.Parse("2a4e56c2-dbce-48db-8e6b-b44108931b98"), Feats.Instances.FangSharpener.ID);
                or.HaveSpecificHeritage(Guid.Parse("4afd97f5-69e7-4ca6-8e4f-1e7d34832da5"), Heritages.Instances.RazortoothGoblin.ID);
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Goblin.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ad6df828-ab8d-4867-be22-803545544aa1"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
