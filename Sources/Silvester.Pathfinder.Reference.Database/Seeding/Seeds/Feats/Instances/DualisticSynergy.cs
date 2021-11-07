using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DualisticSynergy : Template
    {
        public static readonly Guid ID = Guid.Parse("f81d9974-fb88-47a0-9903-4a57f3bba898");

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
            yield return new TextBlock { Id = Guid.Parse("fd7c202c-293c-4664-99c0-dc80176a4c8d"), Type = TextBlockType.Text, Text = "If your next action is to (activity: Cast a Spell) from your spell slots, you gain a benefit. If the spell is arcane, you can attempt a skill check to (action: Recall Knowledge) with a +1 status bonus to the check after casting the spell, or a +2 status bonus if the spell is 7th level or higher. If the spell is primal, you gain a number of temporary Hit Points equal to the spell’s level for 1 round. If the spell is a halcyon spell, you gain both benefits." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ff6bb428-1484-4c97-8ae2-2adef3e95706"), Feats.Instances.HalcyonSpeakerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f5c43485-8780-42e3-a258-1db71db8018a"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
