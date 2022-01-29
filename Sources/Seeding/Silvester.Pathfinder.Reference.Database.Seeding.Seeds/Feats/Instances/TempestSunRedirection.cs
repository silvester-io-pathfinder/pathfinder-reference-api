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
    public class TempestSunRedirection : Template
    {
        public static readonly Guid ID = Guid.Parse("986a8b7f-1fb5-41e2-a58f-f87e407aaa61");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tempest-Sun Redirection",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7eec8271-97f2-4f16-be27-5e2bccf466cb"), Type = TextBlockType.Text, Text = $"If the next action you use is to {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)} from your spell slots that damages other creatures, you can bend some of that spell's offensive energy, protecting allies in the area and boosting your own defenses against certain foes. Select any number of targets of the spell and reduce the spell's damage to those targets by an amount equal to the spell's level. Until your next turn, when one of those targets damages you, that damage is reduced by twice the spell's level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8f97193a-9203-4115-83ae-409b9a785c38"), Feats.Instances.MagaambyanAttendantDedication.ID);
            builder.Manual(Guid.Parse("475af19c-d149-4e21-8368-8f55beffc152"), "Tempest-Sun Mages affiliation");
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("34311afa-2327-4a49-a0ce-96f908458d99"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("81e33163-71b3-41f9-af44-dc189e9fc4c3"), Traits.Instances.Metamagic.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d162d203-9667-4f39-bc33-b6cc5a16fb37"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
