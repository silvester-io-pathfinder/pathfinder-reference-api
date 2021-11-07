using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NosoisMask : Template
    {
        public static readonly Guid ID = Guid.Parse("4652c7db-234b-408f-8f14-35ddb46fb487");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Nosoi's Mask",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("33003e2b-7f2d-485f-b5c2-893c8349453b"), Type = TextBlockType.Text, Text = "Many psychopomps wear masks when dealing with the living, and many cultures believe that seeing an unmasked psychopomp’s face invites death. You are trained in Intimidation and gain the (feat: Intimidating Glare) skill feat. If you were already trained in Intimidation (from your background or class, for example), you instead become trained in a skill of your choice." };
            yield return new TextBlock { Id = Guid.Parse("dbb30d7f-0c5a-4b98-a0d4-8d75e3ade20f"), Type = TextBlockType.Text, Text = "You also know how to make masks like those worn by psychopomps, a process that takes 1 hour and 1 sp of appropriate material. If you instead pay 50 gp for a splendid (item: psychopomp mask | psychopomp mask splendid), the mask grants you a +1 item bonus to Intimidation while you are wearing it. Its usage is worn (mask)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("f23a2dc7-b0df-4d46-bccb-dc6d30861ad7"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1f15646e-5d66-4d86-b6ff-ab8a79500803"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
