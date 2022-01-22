using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImpeccableCrafting : Template
    {
        public static readonly Guid ID = Guid.Parse("e4eae070-87db-4e4a-81a9-97868919e2e2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Impeccable Crafting",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d4fe19b5-6352-44c9-9853-bcee43b7d565"), Type = TextBlockType.Text, Text = $"You craft flawless creations with great efficiency. Whenever you roll a success at a Crafting check to make an item of the type you chose with {ToMarkdownLink<Models.Entities.Feat>("Specialty Crafting", Feats.Instances.SpecialtyCrafting.ID)}, you get a critical success instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("c4aed2d4-76d5-473e-a35a-a70a114e366d"), Proficiencies.Instances.Master.ID, Skills.Instances.Crafting.ID);
            builder.HaveSpecificFeat(Guid.Parse("dbe91ef6-9e0d-4daf-831b-7f91c26fe73b"), Feats.Instances.SpecialtyCrafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("49120930-9a1e-499e-94ec-becc1ac3d768"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
