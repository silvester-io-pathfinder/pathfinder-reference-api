using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TongueTether : Template
    {
        public static readonly Guid ID = Guid.Parse("9bf82e5e-78dc-4eae-af26-e450d36c544f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tongue Tether",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1aa69914-165e-4ed5-a471-c140be7ca6fb"), Type = TextBlockType.Text, Text = "Your tongue can momentarily latch on as readily as your hands. So long as you can freely open your mouth, you do not need free hands in order to (action: Disarm), (action: Grab an Edge), or (action: Trip). If you have the (feat: Long Tongue) feat, you can (action: Disarm), (action: Grab an Edge), and (action: Trip) with your tongue at a distance that is 5 feet beyond your normal reach." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("3a441a36-3469-4220-95dd-761c99f65bee"), Heritages.Instances.SnaptongueGrippli.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("daeed8d2-b753-4e0e-9776-02695e7ad083"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
