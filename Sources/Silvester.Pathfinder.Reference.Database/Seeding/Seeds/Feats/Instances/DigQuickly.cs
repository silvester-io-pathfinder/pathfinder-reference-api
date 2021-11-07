using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DigQuickly : Template
    {
        public static readonly Guid ID = Guid.Parse("16da241f-610d-4c18-bc34-c9d1f76352df");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dig Quickly",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dbdc58b3-e7c6-48e8-8ecc-880bb9727635"), Type = TextBlockType.Text, Text = "Your hands work as effectively as shovels when you need to dig a quick hole. You dig a shallow pit in the square you currently occupy, turning the square into difficult terrain (including for you). In addition, you also kick up a cloud of grit in a direction of your choice. The cloud extinguishes small, unattended, non-magical fires and helps smother the flames on burning creatures located within the cone; creatures in this cone that are taking persistent fire damage can immediately attempt an additional flat DC 15 check to end the persistent damage." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e8043dfb-26ea-4801-aa97-e9eeccb42932"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
