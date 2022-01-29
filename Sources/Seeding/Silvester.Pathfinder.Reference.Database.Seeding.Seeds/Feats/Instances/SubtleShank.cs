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
    public class SubtleShank : Template
    {
        public static readonly Guid ID = Guid.Parse("721abb50-ea29-40c6-ac76-a7781f7f5599");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Subtle Shank",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a9874755-f434-43f0-bbe8-e07c6ad4da99"), Type = TextBlockType.Text, Text = $"~ Access: Help either the Washboard Dogs or the Diobel Sweepers destroy their rival." };
            yield return new TextBlock { Id = Guid.Parse("5a15759b-a0ee-4181-81ff-d572fef69f05"), Type = TextBlockType.Text, Text = $"You draw a concealed weapon, attack with it, and then hide it away again in one smooth motion. {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} to draw the weapon, {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with that weapon, and then {ToMarkdownLink<Models.Entities.SkillAction>("Conceal", SkillActions.Instances.ConcealAnObject.ID)} it with a Stealth check. The target is flat-footed for this attack." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("05d66d7b-d1ca-409f-bbcc-2be8a254b52d"), Feats.Instances.QuickDraw.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("ac38bf20-daea-44be-b33c-a93452b374be"), Traits.Instances.Flourish.ID);
            builder.Add(Guid.Parse("90f2a05d-6765-4e99-a279-6fc791ae7610"), Traits.Instances.Rogue.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("38595813-0bfc-456f-bd46-63f601f6c4fc"),
                SourceId = Sources.Instances.AgentsOfEdgewatch.ID,
                Page = -1
            };
        }
    }
}
