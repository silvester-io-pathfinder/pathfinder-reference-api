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
    public class EmpatheticPlea : Template
    {
        public static readonly Guid ID = Guid.Parse("8aa0075b-a7bc-4f43-9f0d-84a8d20d4d82");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Empathetic Plea",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You are attacked by a creature that you haven't yet acted hostile toward. You must use this reaction before the creature rolls its attack.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9c5bcd51-b6aa-4691-a6ce-a44c27360cf0"), Type = TextBlockType.Text, Text = $"The way you cringe or use those puppy-dog eyes you've been practicing elicits an empathetic response in the attacker. Attempt a Diplomacy check against your attacker's Will DC." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("9ba072ac-b50a-4eae-8068-4111b19389aa"), Proficiencies.Instances.Trained.ID, Skills.Instances.Diplomacy.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Auditory.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Gnome.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Visual.ID);

        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("cdb8aaf8-bc6f-4016-bb82-c0ce412d45df"),
                CriticalSuccess = "The creature pulls its attack, wasting its action, and can't use hostile actions against you until the beginning of its next turn.",
                Success = "The creature takes a -2 circumstance penalty to damage on the triggering (action: Strike) and all its (action: Strikes | Strike) against you until the beginning of its next turn. The penalty is -4 if you're an expert in Diplomacy, -6 if you're a master, and -8 if you're legendary.",
                Failure = "The creature's attack is unaffected, and the creature is temporarily immune to your Empathic Pleas for 24 hours.",
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("93d7e7fd-0fe0-4927-b68c-afb2544e6973"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
