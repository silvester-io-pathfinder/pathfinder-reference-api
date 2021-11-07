using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EndemicHerbs : Template
    {
        public static readonly Guid ID = Guid.Parse("db61e726-4b95-46c5-8161-9352ec477434");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Endemic Herbs",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cd6a39c3-0928-4d9c-acc8-bd9707d308e7"), Type = TextBlockType.Text, Text = "During your daily preparations, you find medicinal plants endemic to your location. Until your next preparations, you can spend an additional batch of herbs to add a benefit to an item you create with your herbalism. The benefit of the special herbs affects the creature that the item is applied to. This adjustment counts as an (trait: additive | Additive 1), so you can’t include another additive without spoiling the item." };
            yield return new TextBlock { Id = Guid.Parse("45f170d9-680c-4082-8b9a-8d2fd9fbdd5f"), Type = TextBlockType.Enumeration, Text = " Aquatic: For 1 minute, gain a +1 circumstance bonus to Fortitude saves." };
            yield return new TextBlock { Id = Guid.Parse("d6f9325b-cd47-4803-b4e1-7b8f35c9b200"), Type = TextBlockType.Enumeration, Text = " Arctic: For 1 hour, treat environmental cold effects as if they were one step less severe." };
            yield return new TextBlock { Id = Guid.Parse("e620d0a9-6277-4f63-b3b4-3112e2f8d44d"), Type = TextBlockType.Enumeration, Text = " Desert: For 1 hour, treat environmental heat effects as if they were one step less severe." };
            yield return new TextBlock { Id = Guid.Parse("ded029ab-331e-41dd-986c-c8b42c1fbd8c"), Type = TextBlockType.Enumeration, Text = " Forest: For 1 minute, gain a +2 circumstance bonus to saves against (trait: disease) and (trait: poison) effects." };
            yield return new TextBlock { Id = Guid.Parse("3448f314-eac5-44e2-834b-efe3353351c0"), Type = TextBlockType.Enumeration, Text = " Mountain: For 1 minute, gain a +1 circumstance bonus to Reflex saves." };
            yield return new TextBlock { Id = Guid.Parse("ea145e81-177d-47b6-a3bf-f5a0f1e3d21d"), Type = TextBlockType.Enumeration, Text = " Plains: For 1 minute, gain a +1 circumstance bonus to Will saves." };
            yield return new TextBlock { Id = Guid.Parse("9e9e60db-b51d-4ed0-a6ae-430bed1dc80d"), Type = TextBlockType.Enumeration, Text = " Swamp: Remove one source of persistent bleed damage." };
            yield return new TextBlock { Id = Guid.Parse("403794ea-23ea-479b-bc13-356e67812fe2"), Type = TextBlockType.Enumeration, Text = " Underground: For 1 minute, gain a +1 circumstance bonus to Perception." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b9a1b5d5-bdd8-43ef-bace-815dde5df73b"), Feats.Instances.HerbalistDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("7613915a-95c1-484b-8c5e-593ee6aef9e3"), Proficiencies.Instances.Trained.ID, Skills.Instances.Survival.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("998ebd45-3082-4db7-a45a-fc81bea2447d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
