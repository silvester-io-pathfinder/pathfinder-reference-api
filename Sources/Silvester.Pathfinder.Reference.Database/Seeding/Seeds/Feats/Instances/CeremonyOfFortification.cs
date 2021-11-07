using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CeremonyOfFortification : Template
    {
        public static readonly Guid ID = Guid.Parse("c2cfb457-a9eb-4efb-b2cb-7e8181356a48");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ceremony of Fortification",
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
            yield return new TextBlock { Id = Guid.Parse("56562d9e-25bb-433d-af28-827f2fd2c8ea"), Type = TextBlockType.Text, Text = "Your exoskeleton arranges itself into an optimal defensive shape. When you use your (feat: Ceremony of Protection), you also gain resistance to either bludgeoning, piercing, or slashing damage equal to half your level against the next (action: Strike) that hits you and deals one of those types of damage until the start of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5af1e662-1946-4f4c-ad76-0578bd3532bc"), Feats.Instances.CeremonyOfProtection.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("162943d3-45d0-41ef-9b88-97777878f175"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
