using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpellmastersTenacity : Template
    {
        public static readonly Guid ID = Guid.Parse("eb7514e0-60a4-4925-ad6a-98b9d4892448");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spellmaster's Tenacity",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You critically fail at a saving throw against a foe's spell, and that spell was cast or created with the tradition of magic you selected with the Spellmaster's Resilience feat.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("43d46707-52f3-434a-9e6a-08f099c78b15"), Type = TextBlockType.Text, Text = "You call upon the power of your spells to protect you from the worst of the magic headed your way. You fail your saving throw instead of critically failing. For 1 minute, increase the circumstance bonus to saving throws from the (feat: Spellmaster&#39;s Resilience) feat to +2, and increase the resistance to damage it grants to 10." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("588b0607-90ba-4a3b-afa8-bda42d40cbc9"), Feats.Instances.SpellmastersResilience.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c2ae8145-2a56-4c5a-ad25-ebbf7b8207e7"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
