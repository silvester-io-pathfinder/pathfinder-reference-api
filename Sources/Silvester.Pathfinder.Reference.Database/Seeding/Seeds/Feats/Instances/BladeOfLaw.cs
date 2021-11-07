using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BladeOfLaw : Template
    {
        public static readonly Guid ID = Guid.Parse("4117823c-76c6-4acc-92d6-6f1fe89c756f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Blade of Law",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("17bbcb90-c5f1-478f-986b-8b12252f91d4"), Type = TextBlockType.Text, Text = "You call upon the power of law and make a weapon or unarmed (action: Strike) against a foe you have witnessed breaking or disrespecting the law or otherwise acting disorderly. The (action: Strike) deals two extra weapon damage dice if the target of your (action: Strike) is chaotic. Whether or not the target is chaotic, you can convert the physical damage from the attack into lawful damage." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e4da34af-7233-458f-aa7d-f6ae9d9a4136"), Feats.Instances.HellknightDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a6a06787-2275-45d6-95d2-4b8536ba6116"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
