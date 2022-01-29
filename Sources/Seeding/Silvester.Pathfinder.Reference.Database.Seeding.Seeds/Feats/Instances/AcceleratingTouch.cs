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
    public class AcceleratingTouch : Template
    {
        public static readonly Guid ID = Guid.Parse("350bd37f-90bf-4c7e-92f4-acec6103ed9f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Accelerating Touch",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b3831bab-3f09-487d-93fb-cad63ffdabba"), Type = TextBlockType.Text, Text = $"Your healing energies are infused with bounding energy. A creature that recovers Hit Points from your {ToMarkdownLink<Models.Entities.Spell>("lay on hands", Spells.Instances.LayOnHands.ID)} gains a +10-foot status bonus to its Speed until the end of its next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSpell(Guid.Parse("02fc4b58-7251-4390-ab8f-501d81380288"), Spells.Instances.LayOnHands.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Champion.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6bd8a00f-feb7-4da6-8524-6c428f2f7448"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
