using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShoulderCatastrophe : Template
    {
        public static readonly Guid ID = Guid.Parse("2da3d725-d85c-4b4d-b609-dbce9daa367f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shoulder Catastrophe",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An enemy critically succeeds at a Strike against an adjacent ally.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bb302f85-883e-44b9-8498-0214fe4da4a3"), Type = TextBlockType.Text, Text = "You’ve trained to protect your allies by diverting the worst attacks to yourself. The enemy doesn’t double the damage from the triggering (action: Strike) but instead applies the normal damage to both you and your ally. Both of you take any effects that would happen on a hit that dealt damage, such as poison, but neither of you are subject to any effects that would happen only on a critical success." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2fd90af0-b180-4337-959e-e45d17003cc2"), Feats.Instances.SwordmasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dac17f8d-1b23-4312-8b0d-50535d6cafe3"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
