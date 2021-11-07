using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StealSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("d4053336-e610-4ebe-a623-40b4a6668ee3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Steal Spell",
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
            yield return new TextBlock { Id = Guid.Parse("eba2f3d4-61a7-4b42-8c76-72edd34061ad"), Type = TextBlockType.Text, Text = "When you use (feat: Legendary Thief) to steal the impossible, you can steal a prepared spell or spontaneous spell from a foe. The spell is randomly selected from the highest-level spells the foe knows that have a target or area, to a maximum of 8th-level spells; the target loses the appropriate spell slot as if they had cast it themself. You can (activity: Cast the Spell | Cast a Spell) once within the next 1d4 rounds, after which the fleeting magic fades; this otherwise works the same as casting a (feat: Loaner Spell)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("774b317c-c808-4cfa-96e5-a651d1f13b0d"), Feats.Instances.LegendaryThief.ID);
            builder.HaveSpecificFeat(Guid.Parse("f87e6471-37f0-4204-b049-d7eacdf5f130"), Feats.Instances.LoanerSpell.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b5fca099-b51c-47d3-96f4-6a0c16cc3759"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
