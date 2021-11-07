using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RubyResurrestion : Template
    {
        public static readonly Guid ID = Guid.Parse("bd837ecc-6fb5-48eb-b895-75668a22ee3f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ruby Resurrestion",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "This feat has the trait corresponding to the tradition of spells you cast.",
                Trigger = "You would be reduced to 0 Hit Points.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4af6b483-a778-434a-9cda-2dc97c385732"), Type = TextBlockType.Text, Text = "In a burst of flame, you return to health like a phoenix rising from the ashes. Change your current Hit Points to 30 and cast a 6th-level (spell: fireball) centered on yourself. This fireball doesn&#39;t affect you. Your hair turns brilliant red for 1 hour." };
            yield return new TextBlock { Id = Guid.Parse("c567ecab-68bd-4b48-af27-ba53ab310101"), Type = TextBlockType.Text, Text = "If you haven&#39;t used Ruby Resurrection and you die, you stay in initiative order and Ruby Resurrection triggers automatically at the start of your next turn, bringing you back to life at 0 HP before having its normal effects. This happens only if there are some remains to resurrect; for instance, if you were killed by disintegrate you wouldn&#39;t return." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("67bfb484-c678-491b-881d-1fe45f9ca3b5"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
