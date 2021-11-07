using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OrnateTattoo : Template
    {
        public static readonly Guid ID = Guid.Parse("1c35010a-ee7c-4ee2-b3fb-8b29add63c0f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ornate Tattoo",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("09676c94-13cf-4b53-9a8a-306f937b4400"), Type = TextBlockType.Text, Text = "You expand your tattoos to encompass greater magic. Choose a 1st-level arcane spell from the same school as your (feat: Arcane Tattoos), either a common spell or another to which you have access. You can cast that spell once per day as an innate arcane spell." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("fa6b65aa-7f6e-47f5-9ad0-c69ef87294de"), Feats.Instances.ArcaneTattoos.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1ef5a7bf-9048-421f-8a62-f27a4a548ab8"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
