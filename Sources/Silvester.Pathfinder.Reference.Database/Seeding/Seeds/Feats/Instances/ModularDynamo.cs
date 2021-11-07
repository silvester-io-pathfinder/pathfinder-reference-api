using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModularDynamo : Template
    {
        public static readonly Guid ID = Guid.Parse("a205826a-41d8-4d77-a02b-bdcdfb8265d1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modular Dynamo",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can select this feat multiple times. Each time, you choose another configuration and add it to the list of options you can choose when you use an (action: Interact) action with the (trait: modular) trait.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("79fd8f62-4fe1-42c1-8cce-15ce1a779c72"), Type = TextBlockType.Text, Text = "Your dynamo has modular configurations, allowing you to swap between various different possibilities with ease in order to adapt to various situations in combat. Your dynamo attack gains the (trait: modular) trait, as well as one of the following configurations of your choice: power driver (1d6 bludgeoning damage; (trait: shove)), percussive striker (1d4 bludgeoning damage; (trait: agile), (trait: finesse)), rotating sickle (1d6 slashing damage; (trait: trip)), or entangling barbs (1d6 piercing damage; (trait: grapple)). If you have a manually controlled dynamo, these damage dice increase by 1 size, as usual, and you can also choose the extendable baton (1d4 bludgeoning damage; (trait: finesse), (trait: reach)), which has the damage increase already factored in." };
            yield return new TextBlock { Id = Guid.Parse("67cce82d-708d-407f-9dc1-71336736a0af"), Type = TextBlockType.Text, Text = "When you use an (action: Interact) action to switch configurations using the (trait: modular) trait, you switch between the initial configuration of dynamo you chose with the (feat: Sterling Dynamo Dedication) and the new configuration you chose with Modular Dynamo." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("af35f0ce-1604-4ff4-879a-32e569b356cb"), Feats.Instances.SterlingDynamoDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4619185a-fb5f-4034-915d-6f60bba77b4f"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
