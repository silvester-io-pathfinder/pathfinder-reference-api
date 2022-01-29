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
    public class DualisticSynergy : Template
    {
        public static readonly Guid ID = Guid.Parse("93552d75-e98e-4f6e-b399-b9bc23317463");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dualistic Synergy",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1d271b06-010d-4fc6-872f-69dd78815386"), Type = TextBlockType.Text, Text = $"If your next action is to {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)} from your spell slots, you gain a benefit. If the spell is arcane, you can attempt a skill check to {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)} with a +1 status bonus to the check after casting the spell, or a +2 status bonus if the spell is 7th level or higher. If the spell is primal, you gain a number of temporary Hit Points equal to the spell's level for 1 round. If the spell is a halcyon spell, you gain both benefits." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5ab8262d-27b6-418a-a8e8-444c223f7ad1"), Feats.Instances.HalcyonSpeakerDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("bc678cc9-4061-43d7-b9ba-bee7dda39cae"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("128e0d2c-fd8b-4961-aefe-e722f9183652"), Traits.Instances.Metamagic.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("87f326c1-c64c-4e6a-8d17-04f63230975a"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
