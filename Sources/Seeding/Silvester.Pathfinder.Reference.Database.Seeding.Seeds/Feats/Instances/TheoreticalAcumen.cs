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
    public class TheoreticalAcumen : Template
    {
        public static readonly Guid ID = Guid.Parse("318b67d1-9291-4de5-8b9a-b358abbaafa4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Theoretical Acumen",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You succeed at a skill check to Recall Knowledge to identify a creature.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2642c925-e3b0-4dc4-8a0e-8f6c7c1eed6b"), Type = TextBlockType.Text, Text = $"You study a creature's form and behavior to hypothesize likely means of overcoming its strengths. Once before the end of your next turn, you can use the skill modifier from the triggering check in place of your saving throw modifier against one of the creature's abilities, in place of your Perception modifier to {ToMarkdownLink<Models.Entities.Action>("Seek", Actions.Instances.Seek.ID)} the creature, in place of your Deception modifier to {ToMarkdownLink<Models.Entities.SkillAction>("Feint", SkillActions.Instances.Feint.ID)} against the creature, or in place of your Intimidation modifier to {ToMarkdownLink<Models.Entities.SkillAction>("Demoralize", SkillActions.Instances.Demoralize.ID)} the creature. Alternatively, against one of the creature's attacks, you can use your DC for the skill used in the triggering check in place of your AC." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("8155718a-7846-483f-84f9-f56acce9d6b5"), Traits.Instances.Gnome.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("58f3b091-054f-48a5-b08a-e9392a4ddd4b"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
