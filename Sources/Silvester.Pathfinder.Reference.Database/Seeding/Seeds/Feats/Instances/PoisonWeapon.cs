using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PoisonWeapon : Template
    {
        public static readonly Guid ID = Guid.Parse("14500875-6d3f-4702-ae9f-ac8a82c5b4aa");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Poison Weapon",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "During your daily preparations, you can prepare a number of simple injury poisons equal to your level. These poisons deal 1d4 poison damage. Only you can apply these poisons properly, and they expire the next time you prepare.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0cf0949a-9728-468d-b0f1-3fa6e5114c94"), Type = TextBlockType.Text, Text = "You apply a poison to the required weapon; if you have a free hand, you can (action: Interact) to draw a poison as part of this action. If your next attack with that weapon before the end of your next turn hits and deals damage, it applies the effects of the poison, provided that poison can be delivered by (trait: contact) or (trait: injury). If you critically fail the attack roll, the poison is wasted as normal." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5fec286d-cf84-4707-8dea-77b7f79a99a1"), Feats.Instances.DrowShootistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8212813e-133a-48d6-8a41-99989f5e1d6a"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
