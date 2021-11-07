using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RevealMachinations : Template
    {
        public static readonly Guid ID = Guid.Parse("372f61b6-4077-4987-85cc-75bd339d7c63");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reveal Machinations",
                Level = 15,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "At the GM's discretion, this feat can be used against non-humanoids if they have regular contact with humanoids or you are able to disguise yourself as a member of the target's ancestry or type of creature.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("abd4e8f7-9801-48fd-9ec1-0a7f18b29a0e"), Type = TextBlockType.Text, Text = "~ Access: Have earnt Mialari Docur’s trust and have proven their worth by defeating the Scarlet Triad." };
            yield return new TextBlock { Id = Guid.Parse("99f3e432-d120-4b2b-b484-a61f50f5fb25"), Type = TextBlockType.Text, Text = "You reveal that you played a minor but recurring role in another humanoid’s life – or at least convince them that’s the case. Attempt a Deception check against the target’s Will DC. On a success, the revelation makes them frightened 2, and on a critical success they are frightened 3. In addition, you gain information about the subject as though you had attempted to (action: Recall Knowledge) about them using an appropriate skill and received the same result on your roll. You can’t use this ability against the same humanoid again until 1 day has passed and you’ve also successfully disguised yourself as a different person." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("78f0fc59-9ff3-41d8-9935-3cd030db0749"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Deception.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4081aefc-3816-4c95-b380-be4f37a92977"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
