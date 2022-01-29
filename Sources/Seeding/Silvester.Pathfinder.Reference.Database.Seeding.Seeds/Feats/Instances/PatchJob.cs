using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PatchJob : Template
    {
        public static readonly Guid ID = Guid.Parse("c230c083-8648-46b6-8746-2cf2f9dd0b0f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Patch Job",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5f22e403-64f3-4484-94c6-3cfde9326b6e"), Type = TextBlockType.Text, Text = $"You can patch up damage to an object with a quick fix. You gain the {ToMarkdownLink<Models.Entities.Feat>("Improvised Repair", Feats.Instances.ImprovisedRepair.ID)} general feat. When you use {ToMarkdownLink<Models.Entities.Feat>("Improvised Repair", Feats.Instances.ImprovisedRepair.ID)}, you can attempt a Crafting check with the same DC as {ToMarkdownLink<Models.Entities.SkillAction>("Repair", SkillActions.Instances.Repair.ID)}. If you succeed, you can use the object as a normal object of its type until it takes damage rather than as a shoddy object of its type." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("13bc166c-48c1-4972-a066-faf1ab0bb303"), Feats.Instances.VehicleMechanicDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6ace0b1a-354f-4992-b3d3-574473e51695"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
