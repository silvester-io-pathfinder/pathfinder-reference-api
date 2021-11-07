using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UbiquitousGadgets : Template
    {
        public static readonly Guid ID = Guid.Parse("ff89b04b-89b3-4ea5-a74e-edf40c9a62ce");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ubiquitous Gadgets",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can select this feat a second time if you are 14th level or higher.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("74a14c5a-233d-4c10-8ff9-1fa7bd2749f8"), Type = TextBlockType.Text, Text = "They thought you had used up all your devices, but they thought wrong! You have a few more gadgets up your sleeve than others expect. Increase the number of temporary gadgets you can create each day by 2." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3abf078e-7e74-4fe8-9f2b-afe34466e9be"), Feats.Instances.GadgetSpecialist.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5cc9ed2c-21d5-4b8c-a124-e72de001a143"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
