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
    public class DemonbloodFrenzy : Template
    {
        public static readonly Guid ID = Guid.Parse("a3ca284a-f12e-4631-a83c-79b3fc42a280");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Demonblood frenzy",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You successfully Strike a living creature that has the fiend trait with your tusks unarmed attack.",
                Frequency = "once per minute"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("81cec84d-373a-45a8-88d5-b1f7816c5a7d"), Type = TextBlockType.Text, Text = $"Just the taste of fiendish blood is enough to send blood rushing through your veins in a supernatural fury. You become quickened until the end of your next turn and you can use the extra action to make a tusks {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}, {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)}, or {ToMarkdownLink<Models.Entities.Action>("Step", Actions.Instances.Step.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificUnarmedAttack(Guid.Parse("6bb3647b-c44a-491c-8a4b-3e4fd2196fb0"), UnarmedWeapons.Instances.Tusks.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Orc.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("04474cc6-daf6-46c3-a0f3-ddc5b178f0fd"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
