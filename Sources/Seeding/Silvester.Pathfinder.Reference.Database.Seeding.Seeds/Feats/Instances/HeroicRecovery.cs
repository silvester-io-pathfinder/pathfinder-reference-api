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
    public class HeroicRecovery : Template
    {
        public static readonly Guid ID = Guid.Parse("d8714e84-dc33-49ab-bf74-63be80d950fc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Heroic Recovery",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7119a050-4d8b-4482-9309-cdbdc6e3da28"), Type = TextBlockType.Text, Text = $"The restorative power of your healing invigorates the recipient. If the next action you use is to cast {ToMarkdownLink<Models.Entities.Spell>("heal", Spells.Instances.Heal.ID)} targeting a single living creature and the target regains Hit Points from the spell, it also gains three bonuses until the end of its next turn: a +5-foot status bonus to its Speed, a +1 status bonus to attack rolls, and a +1 status bonus to damage rolls." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineFont(Guid.Parse("4dbd96e8-0cb8-487e-b515-413d51d231a9"), DivineFonts.Instances.Heal.ID);
            builder.AddOr(Guid.Parse("5baa3378-7806-4079-9e24-93438895f80d"), or => 
            {
                or.HaveSpecificAlignment(Guid.Parse("22c513cc-295f-416a-bf07-a3cb671b8186"), Alignments.Instances.LawfulGood.ID);
                or.HaveSpecificAlignment(Guid.Parse("6163a4ea-8849-47e2-9df0-41368f4469d3"), Alignments.Instances.ChaoticGood.ID);
                or.HaveSpecificAlignment(Guid.Parse("b3be3a0d-13af-4abb-abe3-fe4e58339f1d"), Alignments.Instances.NeutralGood.ID);
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("71f6ea74-a085-4edb-a8b6-b546aefba368"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
