using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FiendsbaneOath : Template
    {
        public static readonly Guid ID = Guid.Parse("eb9f84c6-79f3-4a72-bdae-db1077fac558");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fiendsbane Oath",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f98d94ab-0889-44e5-95a7-b0fece693f54"), Type = TextBlockType.Text, Text = "You’ve sworn an oath to banish the corruption of fiends to the dark planes they call home. Add the following tenet to your champion’s code after the other tenets:" };
            yield return new TextBlock { Id = Guid.Parse("0fb21fb6-e0ca-451a-aa90-fc5fc47f0cf0"), Type = TextBlockType.Enumeration, Text = " : You must banish or slay fiends you come across as long as you have a reasonable chance of success; in the incredibly unlikely event you find a good fiend, you don’t have to banish or kill it." };
            yield return new TextBlock { Id = Guid.Parse("a8d72f14-76ad-4f2a-932c-95596afbf0d8"), Type = TextBlockType.Text, Text = "Your (feat: Retributive Strike) gains a +4 circumstance bonus to damage against a fiend, or a +6 circumstance bonus if you have master proficiency with the weapon you used." };
            yield return new TextBlock { Id = Guid.Parse("82e258a1-e876-431c-9f99-b987c6f9dc64"), Type = TextBlockType.Text, Text = "Your (feat: Glimpse of Redemption)’s resistance against damage from a fiend is 7 + your level." };
            yield return new TextBlock { Id = Guid.Parse("9ed29622-d8b9-405a-8d21-f2de6b0712d2"), Type = TextBlockType.Text, Text = "If you use (feat: Liberating Step) triggered by a fiend, your ally gains a +4 circumstance bonus to checks granted by your (feat: Liberating Step), and the ally can (action: Step) twice afterward." };
            yield return new TextBlock { Id = Guid.Parse("2900ab74-aa78-42a1-b379-c690361963ce"), Type = TextBlockType.Text, Text = "You don’t consider fiends to be legitimate authorities, even in nations ruled by fiends." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificTenet(Guid.Parse("4be19dbb-1f1e-4579-9ad7-c8f52855bc20"), Tenets.Instances.Good.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6b72e412-3d11-4be0-940d-b45ade4a4739"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
