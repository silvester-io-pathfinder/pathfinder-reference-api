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
    public class RightHandBlood : Template
    {
        public static readonly Guid ID = Guid.Parse("c4d33f45-a92f-4bc9-b8e1-cc875698236d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Right-Hand Blood",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("84a784a0-5950-4b50-a7fb-9b9edc0af337"), Type = TextBlockType.Text, Text = $"It's said that the flesh of the right side of a hyena can heal diseases, but that of the left side is poisonous. You can take 1 damage to feed someone blood from your right side and {ToMarkdownLink<Models.Entities.SkillAction>("Administer First Aid", SkillActions.Instances.AdministerFirstAid.ID)} or take 2d8 damage to {ToMarkdownLink<Models.Entities.SkillAction>("Treat Disease", SkillActions.Instances.TreatDisease.ID)} or {ToMarkdownLink<Models.Entities.SkillAction>("Treat Wounds", SkillActions.Instances.TreatWounds.ID)}; in either case, you don't need {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("healer's tools", Items.AdventuringGears.Instances.HealersTools.ID)}, and gain a +1 item bonus. Blood from your left side causes the check to critically fail automatically." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("0438cdc5-3ef3-4c31-be75-25335cc6dd1a"), Traits.Instances.Gnoll.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f0892a9a-5883-4f73-b920-8f97db7a627d"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
