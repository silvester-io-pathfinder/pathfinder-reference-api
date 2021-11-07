using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InventiveOffensive : Template
    {
        public static readonly Guid ID = Guid.Parse("e021d71e-94d1-4f42-a073-d6eafd53eb8d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Inventive Offensive",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("25270adc-987c-4a38-a2e2-ceec73433c9b"), Type = TextBlockType.Text, Text = "You can jury-rig your weapons to perform in unexpected ways. When you use this ability, add one of the following weapon traits to a melee weapon you wield: (trait: deadly d6), (trait: disarm), (trait: nonlethal), (trait: shove), (trait: trip), (trait: versatile B), (trait: versatile P), or (trait: versatile S). You cannot add a trait that the weapon already has. The weapon retains this trait until you a successfully hit and deal damage with the weapon. The weapon retains this trait only while you wield it, and you can have only one weapon modified in this way at any time." };
            yield return new TextBlock { Id = Guid.Parse("59712222-170f-426d-aab4-140978f5c72d"), Type = TextBlockType.Text, Text = " If you have expert proficiency in Crafting, you can use this feat as a 2-action activity. If you have legendary proficiency in Crafting, you can apply two weapon traits from the list when using this feat." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("519f3154-d73e-4c06-b770-7d0543c588ab"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("459006b0-867d-4e02-b87d-8b3fb8a2ad4e"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
