using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CavalierDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("ee30f0cf-9a7b-4ab2-8c5e-8a0d0ca55762");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cavalier Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the cavalier archetype. This restriction is waived if you have pledged to the organization associated with the other dedication feat. For example, if you are pledged to a Hellknight order, you could take Hellknight dedication feats without needing to gain other feats from the cavalier archetype first.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4e6a6b79-bb93-4783-accc-9e1e6273dc43"), Type = TextBlockType.Text, Text = $"You gain a young animal companion (page 214) that serves as your mount. You can choose from animal companions with the mount special ability, as well as any additional options from your pledge, as determined by your GM. You must choose an animal companion that's at least one size larger than you, but if the animal usually starts as Small, you can begin with a Medium version of that animal (changing no statistics other than its size)." };
            yield return new TextBlock { Id = Guid.Parse("b3ca9649-73b8-455b-90e8-61a97b89043a"), Type = TextBlockType.Enumeration, Text = $"**Cavalier Pledges***" };
            yield return new TextBlock { Id = Guid.Parse("391bec08-4686-4594-a0bf-9c59f238cdb4"), Type = TextBlockType.Text, Text = $":&gt; Many cavaliers pledge themselves in service to a specific organization or individual, such as a noble family or sovereign ruler, a knightly order or another organization, or a particular ideal. A cavalier pledged to an order or ideal must uphold its edicts and is beholden to any anathema it has; for example, a cavalier pledged to the druid's animal order would be tied to that anathema, while a cavalier pledged to the church of Abadar would be held to the same standards as a cleric of that god. If you pledge yourself to an entity or cause without a stated anathema, you should work with your GM to determine the edicts and anathema associated with your pledge." };
            yield return new TextBlock { Id = Guid.Parse("1a419b3e-6432-40f5-a96e-bfae6e49b824"), Type = TextBlockType.Text, Text = $":&gt; Cavaliers who have pledged themselves can gain access to certain abilities related to that pledge, such as Cavalier's Banner. If you violate the anathema of your pledge, you lose access to those feats until you benefit from an atone ritual. Changing the subject of your pledge is equivalent to retraining a class feature." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("d4bd7d58-b9df-4556-bf7e-7a29281d51f2"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("1ad2d9d6-c867-440e-8ac3-73d58b327c9e"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("ca4ef70a-5d11-4aaa-a20f-85192fed74d3"), Proficiencies.Instances.Trained.ID, Skills.Instances.Society.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e0bd27b1-8ae6-4240-80d5-a33e5c382db0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
