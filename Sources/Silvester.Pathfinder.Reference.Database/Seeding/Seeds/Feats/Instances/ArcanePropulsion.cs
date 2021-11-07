using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArcanePropulsion : Template
    {
        public static readonly Guid ID = Guid.Parse("f454aa32-6445-4ed3-850a-08ac7e8318ad");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Arcane Propulsion",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b773a7dc-0690-4657-8007-a87d39db4a64"), Type = TextBlockType.Text, Text = "You redirect energy from your core to ports on your back or feet, allowing you to fly for a short time. You can maintain this redirected energy for 5 minutes. You gain a fly Speed equal to your Speed while redirecting the energy." };
            yield return new TextBlock { Id = Guid.Parse("cb1887aa-a0e8-445b-9ed5-56db5d703ae6"), Type = TextBlockType.Text, Text = "----" };
            yield return new TextBlock { Id = Guid.Parse("5e6e8158-99ab-4d5d-a286-f9efc7e97742"), Type = TextBlockType.Text, Text = "~ Enhancement: You can maintain your flight for longer. You can redirect your energy at all times, allowing you to fly whenever you want, rather than just once per day for 5 minutes." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("92f22479-b386-43da-a4aa-95c335ddcb83"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
