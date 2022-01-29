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
    public class EternalBlessing : Template
    {
        public static readonly Guid ID = Guid.Parse("5fbf333f-1a79-4127-8242-e38fc04a4b77");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eternal Blessing",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4f2b5896-53a8-49ea-8af3-bf7c20adc58f"), Type = TextBlockType.Text, Text = $"Your good deeds have brought your deity's grace to you for all of eternity. You're continuously surrounded by a {ToMarkdownLink<Models.Entities.Spell>("bless", Spells.Instances.Bless.ID)} spell with a spell level equal to half your level (rounded up). The radius is 15 feet, and you can't increase it. You can {ToMarkdownLink<Models.Entities.Action>("Dismiss", Actions.Instances.Dismiss.ID)} the spell; if you do, it returns automatically after 1 minute." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("1efd7ce1-2283-4f72-a4df-dd67948bf9d9"), or => 
            {
                or.HaveSpecificAlignment(Guid.Parse("5a0cebcb-63fc-4426-bd35-e92e7579caa6"), Alignments.Instances.LawfulGood.ID);
                or.HaveSpecificAlignment(Guid.Parse("297e0b44-fed3-49d9-8309-697e3b2d27f8"), Alignments.Instances.ChaoticGood.ID);
                or.HaveSpecificAlignment(Guid.Parse("e397226a-bf1c-4d5b-bc14-451879ce6a3f"), Alignments.Instances.NeutralGood.ID);
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("62b05f5e-4668-4563-8891-46f335ecde7d"), Traits.Instances.Cleric.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5784c0e0-3ab0-4725-a5aa-186ab35aad7a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
