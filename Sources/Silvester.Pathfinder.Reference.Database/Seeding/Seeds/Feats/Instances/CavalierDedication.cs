using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CavalierDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("2f6bc12c-5576-443c-aa07-2e29529257ac");

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
            yield return new TextBlock { Id = Guid.Parse("818bab5b-233e-4a5c-a877-e8ff37a715d9"), Type = TextBlockType.Text, Text = "You gain a young animal companion (page 214) that serves as your mount. You can choose from animal companions with the mount special ability, as well as any additional options from your pledge, as determined by your GM. You must choose an animal companion that’s at least one size larger than you, but if the animal usually starts as Small, you can begin with a Medium version of that animal (changing no statistics other than its size)." };
            yield return new TextBlock { Id = Guid.Parse("3bf1ba1e-f511-4a90-91ff-0249f6191d44"), Type = TextBlockType.Enumeration, Text = "**Cavalier Pledges***" };
            yield return new TextBlock { Id = Guid.Parse("d28ef732-8426-48df-81dd-e7ded9709413"), Type = TextBlockType.Text, Text = ":&gt; Many cavaliers pledge themselves in service to a specific organization or individual, such as a noble family or sovereign ruler, a knightly order or another organization, or a particular ideal. A cavalier pledged to an order or ideal must uphold its edicts and is beholden to any anathema it has; for example, a cavalier pledged to the druid’s animal order would be tied to that anathema, while a cavalier pledged to the church of Abadar would be held to the same standards as a cleric of that god. If you pledge yourself to an entity or cause without a stated anathema, you should work with your GM to determine the edicts and anathema associated with your pledge." };
            yield return new TextBlock { Id = Guid.Parse("7725c4d9-d0d4-4883-8b84-b788fec949ee"), Type = TextBlockType.Text, Text = ":&gt; Cavaliers who have pledged themselves can gain access to certain abilities related to that pledge, such as Cavalier’s Banner. If you violate the anathema of your pledge, you lose access to those feats until you benefit from an atone ritual. Changing the subject of your pledge is equivalent to retraining a class feature." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("5674fc3b-bfc8-456c-8d54-b702666cf27b"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("9443fdfe-2f29-43a7-a9a9-a577f3d62fd0"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("f19a9b09-c6aa-4e77-870f-17da378d4ef4"), Proficiencies.Instances.Trained.ID, Skills.Instances.Society.ID);
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
                Id = Guid.Parse("e61e5f71-7be2-43e1-a55d-e3756d767ef4"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
