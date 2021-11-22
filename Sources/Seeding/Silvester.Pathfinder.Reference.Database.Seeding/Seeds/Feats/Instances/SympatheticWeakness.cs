using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SympatheticWeakness : Template
    {
        public static readonly Guid ID = Guid.Parse("5b5f667a-4a7e-4d27-b052-99b7dd1f5f8a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sympathetic Weakness",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("abde104e-56f7-442a-93d5-73f6e00f3ce5"), Type = TextBlockType.Text, Text = "You've learned how to expand your invocation of esoterica to apply not just to a specific individual, but other creatures with similar weaknesses, bringing you greater power. While you benefit from (feat: Esoteric Antithesis), your (action: Strikes|Strike) also count towards the weakness of any other creature with the same weakness your (feat: Esoteric Antithesis) is set to. For instance, if you used (feat: Esoteric Antithesis) on a red dragon, revealing its weakness 20 to cold and causing your (action: Strikes|Strike) to deal additional damage, you would also deal additional damage to the dragon's fire elemental minions, which have weakness 10 to cold. No other effects of (feat: Esoteric Antithesis) apply to other creatures with the same weakness, and this feat has no effect when you create a custom weakness in a creature that otherwise has none." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("645213f5-737f-4b73-b2b4-5156cc01f860"), Feats.Instances.EsotericAntithesis.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("862f5a5e-415d-4e3b-b2ee-b4370f706850"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
