using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InventiveOffensive : Template
    {
        public static readonly Guid ID = Guid.Parse("b89cc682-d7d2-47aa-b42f-5813c96aea6e");

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
            yield return new TextBlock { Id = Guid.Parse("772c1638-dca4-4eac-b68c-eeffa7778103"), Type = TextBlockType.Text, Text = $"You can jury-rig your weapons to perform in unexpected ways. When you use this ability, add one of the following weapon traits to a melee weapon you wield: {ToMarkdownLink<Models.Entities.Trait>("deadly", Traits.Instances.Deadly.ID)} d6, {ToMarkdownLink<Models.Entities.Trait>("disarm", Traits.Instances.Disarm.ID)}, {ToMarkdownLink<Models.Entities.Trait>("nonlethal", Traits.Instances.Nonlethal.ID)}, {ToMarkdownLink<Models.Entities.Trait>("shove", Traits.Instances.Shove.ID)}, {ToMarkdownLink<Models.Entities.Trait>("trip", Traits.Instances.Trip.ID)}, {ToMarkdownLink<Models.Entities.Trait>("versatile B", Traits.Instances.Versatile.ID)}, {ToMarkdownLink<Models.Entities.Trait>("versatile P", Traits.Instances.Versatile.ID)}, or {ToMarkdownLink<Models.Entities.Trait>("versatile S", Traits.Instances.Versatile.ID)}. You cannot add a trait that the weapon already has. The weapon retains this trait until you a successfully hit and deal damage with the weapon. The weapon retains this trait only while you wield it, and you can have only one weapon modified in this way at any time." };
            yield return new TextBlock { Id = Guid.Parse("0cc2f38c-c7c4-4279-99ee-a7746e2ccec1"), Type = TextBlockType.Text, Text = $" If you have expert proficiency in Crafting, you can use this feat as a 2-action activity. If you have legendary proficiency in Crafting, you can apply two weapon traits from the list when using this feat." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("d01b925c-496f-4104-93eb-179d80745c60"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2786f9d7-62e3-4cdd-af5f-238ca3f809b0"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
