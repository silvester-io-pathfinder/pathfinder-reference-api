using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeathsDoor : Template
    {
        public static readonly Guid ID = Guid.Parse("cc06db7a-8f0a-4aaa-87f0-4a2ff35b4c80");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Death's Door",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You take damage that would reduce you to 0 Hit Points.",
                Frequency = "once per 10 minutes"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9e14591e-17ab-40f6-900e-68a73d565705"), Type = TextBlockType.Text, Text = "You continue to fight when others would fall. Just before taking the triggering damage, you gain temporary Hit Points equal to twice your level. If you have Hit Points remaining after gaining these temporary Hit Points, you aren’t knocked unconscious, nor do you suffer the other effects of being reduced to 0 Hit Points. Any temporary Hit Points that remain after applying the damage last for up to 4 rounds." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("df5c582a-f62d-45fb-a6e5-976caf424712"), Feats.Instances.SwordmasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e3998a08-359f-41a5-8936-e0e76b85b9d8"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
